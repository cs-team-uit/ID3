using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3
{
    class TreeNode
    {
        public TreeNode() //Thêm hàm
        {
            Attributes = null;
        }
        public TreeNode(Attribute at) //Thêm hàm
        {
            Attributes = at;
        }
         
        public TreeNode AddNode(TreeNode tree) //Thêm hàm
        {
            return this;
        }

        public Attribute Attributes;

        public TreeNode[] Childs;
    }
        
}
