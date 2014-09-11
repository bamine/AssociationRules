using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRules
{
    public class ItemSet : ArrayList
    {
        public ItemSet()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        private int icount = 0;

        public int ICount
        {
            get { return icount; }
            set { icount = value; }
        }
        public override object Clone()
        {
            ArrayList al = (ArrayList)base.Clone();
            ItemSet set = new ItemSet();
            for (int i = 0; i < al.Count; i++)
            {

                set.Add(al[i]);
            }


            set.ICount = this.icount;
            return set;
        }
        public override bool Equals(object obj)
        {

            ArrayList al = (ArrayList)obj;

            //al.Sort(StringComparer.CurrentCulture);
            //this.Sort(StringComparer.CurrentCulture);
            if (al.Count != this.Count) return false;
            for (int i = 0; i < al.Count; i++)
            {

                if (!al[i].Equals(this[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
