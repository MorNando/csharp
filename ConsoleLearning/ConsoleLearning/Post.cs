using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _posttime = new DateTime();
        private int _vote = 0;

        public string Title { get { return _title; } private set { } }
        public string Description { get { return _description; } private set { } }
        public DateTime PostTime { get { return _posttime; } private set { } }
        public int Votes { get { return _vote; } private set { } }
        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _posttime = DateTime.Now;
        }

        public void Upvote()
        {
            _vote = _vote + 1;
        }

        public void DownVote()
        {
            _vote = _vote - 1;
        }
    }
}
