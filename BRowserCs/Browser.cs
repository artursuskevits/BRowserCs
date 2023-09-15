using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRowserCs
{
    public class Browser
    {
        private Stack<string> _back = new Stack<string>();
        private Stack<string> _forward = new Stack<string>();
        private List<string> _history = new List<string>();

        private string _current;
        private string _homepage;

        public Browser(string homepage)
        {
            _homepage = homepage;
            Console.WriteLine("Your home page -> ");
            GoTo(homepage);
        }

        public string Homepage
        {
            get => _homepage;
            set => _homepage = value;
        }
        public static void Change_homepage(Browser br)
        {
            Console.WriteLine("Write new homepage");
            string nhomepage = Console.ReadLine();
            br.Homepage = nhomepage;
            Console.WriteLine("Your home page -> ");
            br.GoTo(nhomepage);
        }
        public static void go_to_honepage(Browser br)
        {
            Console.WriteLine("Your home page -> {0} ",br.Homepage);
            br.GoTo(br.Homepage);
        }

        public void GoTo(string url)
        {
            _back.Push(_current);
            _current = url;
            _forward.Clear();
            _history.Add(url);
        }

        public void Back()
        {
            if (_back.Count > 0)
            {
                _forward.Push(_current);
                _current = _back.Pop();
                _history.Add(_current);
            }
        }

        public void Forward()
        {
            int howmanylinks = _forward.Count;

            if (_forward.Count > 0)
            {
                _back.Push(_current);
                _current = _forward.Pop();
                _history.Add(_current);
            }
        }

        public string Current()
        {
            return _current;
        }

        public List<string> History()
        {
            return _history;
        }
    }
}
