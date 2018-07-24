 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Northwoods.Go;
using Northwoods.Go.Layout;
using Northwoods.Go.Xml;
using System.IO;

namespace Line_Balancing_GUI
{
    public partial class FormDiagram : Form
    {
        private List<string[]> rawData;
        private GoBasicNode[] nodes;
        private GoLink[] links;
        private int indexNumber;
        private List<KeyValuePair<int, float>> timeSeq;

        public FormDiagram(List<string[]> pre_data, List<KeyValuePair<int, float>> time_sequence)
        {
            InitializeComponent();

            this.Text = Application.ProductName + " - Precedence Diagram";

            rawData = pre_data;
            indexNumber = time_sequence.Count;

            nodes = new GoBasicNode[indexNumber];
            links = new GoLink[rawData.Count];

            timeSeq = time_sequence;
            createDiagram(rawData);

            #region Graph Data Test

            #region Adding Transformer

            GoBasicNode node = new GoBasicNode();
            GoXmlBindingTransformer x = new GoXmlBindingTransformer("node", node);
            x.IdAttributeUsedForSharedObjects = true;
            x.TreeStructured = true;
            x.TreeLinkPrototype = new GoLink();
            x.TreeLinksToChildren = true;
            x.AddBinding("label", "Text");
            x.AddBinding("parent", "TreeParentNode");

            #endregion

            GoXmlWriter w = new GoXmlWriter();
            w.AddTransformer(x);
            w.Objects = goViewDiagram.Document;
            using (StreamWriter writer = new StreamWriter("output.xml"))
            {
                w.Generate(writer);
            }
            #endregion
        }

        private void createDiagram(List<string[]> rawData)
        {
            PointF ref_point = new PointF(100, 100);

            // Nodes Creation
            for (int i = 0; i < indexNumber; i++)
            {
                GoBasicNode node = new GoBasicNode(GoFigure.Circle);
                node.Text = timeSeq.ElementAt(i).Key.ToString();
                node.Location = new PointF(ref_point.X + (i * 100), ref_point.Y);
                nodes[i] = node;
            }

            //Links Creation
            for (int i = 0; i < rawData.Count; i++)
            {
                GoLink link = new GoLink();
                link.ToArrow = true;

                // getting associated node
                string[] dt = rawData.ElementAt(i);
                var nodesAquired = Array.FindAll(nodes, s => s.Text == dt[0]);
                var nodeTo = nodesAquired[0];

                nodesAquired = Array.FindAll(nodes, s => s.Text == dt[1] && s.Text != "0");

                if (nodesAquired.Length > 0)
                {
                    var nodeFrom = nodesAquired[0];

                    link.FromPort = nodeFrom.Port;
                    link.ToPort = nodeTo.Port;
                    links[i] = link;
                }
            }

            // Add All Nodes to doc
            foreach (var item in nodes)
            {
                goViewDiagram.Document.Add(item);
            }

            // Add All Links to doc
            foreach (var item in links)
            {
                if (item != null)
                {
                    goViewDiagram.Document.Add(item);
                }
            }

            // Perform layout
            GoLayoutTree layout = new GoLayoutTree();
            layout.Document = goViewDiagram.Document;
            layout.PerformLayout();

            foreach (var item in nodes)
            {
                PointF current = item.Location;
                item.Location = new PointF(current.X + 50, current.Y + 250);
            }
        }
    }
}
