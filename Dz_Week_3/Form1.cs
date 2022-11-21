using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DriveInfo[] drives = DriveInfo.GetDrives();
            TreeNode[] drivesTreeNode = new TreeNode[drives.Length];
            for (int j = 0; j < drives.Length; j++)
            {
                drivesTreeNode[j] = new TreeNode(drives[j].Name);
            }

            DirectoryInfo directoryFirstLevel = new DirectoryInfo(drives[0].Name);
            TreeNode[] innerNodes = new TreeNode[(directoryFirstLevel.GetDirectories().Length + directoryFirstLevel.GetFiles().Length)];


            int i = 0;
            for (; i < (directoryFirstLevel.GetDirectories().Length); i++)
            {
                innerNodes[i] = new TreeNode(directoryFirstLevel.GetDirectories()[i].Name);
            }
            for (int j = 0; i < (directoryFirstLevel.GetDirectories().Length + directoryFirstLevel.GetFiles().Length); i++, j++)
            {
                innerNodes[i] = new TreeNode(directoryFirstLevel.GetFiles()[j].Name);
            }
            drivesTreeNode[0] = new TreeNode(drives[0].Name, innerNodes);

            int position = 0;
            foreach (DirectoryInfo direct in directoryFirstLevel.GetDirectories())
            {
                if (direct.Name == "Program Files")
                {
                    break;
                }
                position++;
            }

            DirectoryInfo directorySecondLevel = new DirectoryInfo(drives[0].Name + directoryFirstLevel.GetDirectories()[position].Name);
            innerNodes = new TreeNode[(directorySecondLevel.GetDirectories().Length + directorySecondLevel.GetFiles().Length)];

            i = 0;
            for (; i < (directorySecondLevel.GetDirectories().Length); i++)
            {
                innerNodes[i] = new TreeNode(directorySecondLevel.GetDirectories()[i].Name);
            }
            for (int j = 0; i < (directorySecondLevel.GetDirectories().Length + directorySecondLevel.GetFiles().Length); i++, j++)
            {
                innerNodes[i] = new TreeNode(directorySecondLevel.GetFiles()[j].Name);
            }
            drivesTreeNode[0].Nodes[position] = new TreeNode(directoryFirstLevel.GetDirectories()[position].Name, innerNodes);

            explorerTreeView.Nodes.AddRange(drivesTreeNode);
        }

        private void explorerTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
