using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Repository
    {
        private Random _rnd;

        public Repository()
        {
            _rnd = new Random();
        }

        public Task<bool> GetAll(ICollection<string> list, int count)
        {
            for(int i = 0; i < count; i++)
            {
                list.Add(RandomString(10));
            }
            return Task.FromResult(true);
        }

        internal string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[_rnd.Next(chars.Length)]).ToArray());
        }
    }
}
