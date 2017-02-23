using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkerRole1
{
    class UrlTitle : TableEntity
    {
        public UrlTitle(string url, string title)
        {
            this.PartitionKey = title;
            this.RowKey = Guid.NewGuid().ToString();
            this.title = title;
        }

        private string title { get; set; }
        private string url { get; set; }
    }
}
