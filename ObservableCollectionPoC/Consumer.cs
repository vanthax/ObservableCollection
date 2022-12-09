using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Consumer
    {

        public async Task PopulateList()
        {
            var list = new ObservableCollection<string>();

            //add event handler
            list.CollectionChanged += HandleChange;

            var repository = new Repository();
            var result = await repository.GetAll(list, 50000);
            Console.WriteLine(result);

            foreach (var item in list) { }
        }

        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach(var item in e.NewItems)
                Console.WriteLine(item.ToString());
        }
    }
}

