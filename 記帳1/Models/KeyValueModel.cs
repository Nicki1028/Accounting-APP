using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 記帳1.Models
{
    internal class KeyValueModel
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public KeyValueModel(string Key,int Value) {
            this.Key = Key;
            this.Value = Value;
        }  
    }
}
