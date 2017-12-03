using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Glog
{
    class Glog
    {
        string form = @"https://docs.google.com/forms/d/12ax9XqADN6WFAhbOexn2avnMNdt_N9VK6jDPAxc2-5k/formResponse";
        List<string> nameForm = new List<string>();

        public Glog()
        {
            form = @"https://docs.google.com/forms/d/12ax9XqADN6WFAhbOexn2avnMNdt_N9VK6jDPAxc2-5k/formResponse";
            nameForm.Add("entry.737527547");
            nameForm.Add("entry.1751246945");
            nameForm.Add("entry.643738934");
            nameForm.Add("entry.1283472147");
            nameForm.Add("entry.668328527");
            nameForm.Add("entry.1985321813");
        }
        public Glog(string adress, List<string> name)
        {
            if (name.Count == 0) { throw new Exception("GoogleFormLog: "); }
            form = @"https://docs.google.com/forms/d/" + adress + "/formResponse";
            for (int i = 0; i < 6 && i < name.Count; i++)
            {
                nameForm.Add(name[i]);
            }
        }

        public void Write(object text)
        {
            if (nameForm.Count < 1) { return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + text.ToString();
            SendData(postDate);
        }
        public void Write(object box1, object box2)
        {
            if (nameForm.Count < 2) { Write("Form have columns < 2! result: " + "[" + box1 + "] [" + box2 + "]"); return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + box1.ToString();
            postDate += "&";
            postDate += nameForm[1] + "=" + box2.ToString();
            SendData(postDate);
        }
        public void Write(object box1, object box2, object box3)
        {
            if (nameForm.Count < 3) { Write("Form have columns < 3! result: " + "[" + box1 + "] [" + box2 + "] [" + box3 + "]"); return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + box1.ToString();
            postDate += "&";
            postDate += nameForm[1] + "=" + box2.ToString();
            postDate += "&";
            postDate += nameForm[2] + "=" + box3.ToString();
            SendData(postDate);
        }
        public void Write(object box1, object box2, object box3, object box4)
        {
            if (nameForm.Count < 4) { Write("Form have columns < 4! result: " + "[" + box1 + "] [" + box2 + "] [" + box3 + "] [" + box4 + "]"); return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + box1.ToString();
            postDate += "&";
            postDate += nameForm[1] + "=" + box2.ToString();
            postDate += "&";
            postDate += nameForm[2] + "=" + box3.ToString();
            postDate += "&";
            postDate += nameForm[3] + "=" + box4.ToString();
            SendData(postDate);
        }
        public void Write(object box1, object box2, object box3, object box4, object box5)
        {
            if (nameForm.Count < 5) { Write("Form have columns < 5! result: " + "[" + box1 + "] [" + box2 + "] [" + box3 + "] [" + box4 + "] [" + box5 + "]"); return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + box1.ToString();
            postDate += "&";
            postDate += nameForm[1] + "=" + box2.ToString();
            postDate += "&";
            postDate += nameForm[2] + "=" + box3.ToString();
            postDate += "&";
            postDate += nameForm[3] + "=" + box4.ToString();
            postDate += "&";
            postDate += nameForm[4] + "=" + box5.ToString();
            SendData(postDate);
        }
        public void Write(object box1, object box2, object box3, object box4, object box5, object box6)
        {
            if (nameForm.Count < 6) { Write("Form have columns < 6! result: " + "[" + box1 + "] [" + box2 + "] [" + box3 + "] [" + box4 + "] [" + box5 + "] [" + box6 + "]"); return; }
            string postDate = "";
            postDate += nameForm[0] + "=" + box1.ToString();
            postDate += "&";
            postDate += nameForm[1] + "=" + box2.ToString();
            postDate += "&";
            postDate += nameForm[2] + "=" + box3.ToString();
            postDate += "&";
            postDate += nameForm[3] + "=" + box4.ToString();
            postDate += "&";
            postDate += nameForm[4] + "=" + box5.ToString();
            postDate += "&";
            postDate += nameForm[5] + "=" + box6.ToString();
            SendData(postDate);
        }

        void SendData(string str)
        {
            try
            {
                var request = WebRequest.Create(form);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                var requestBody = Encoding.ASCII.GetBytes(str);
                request.ContentLength = requestBody.Length;
                var stream = request.GetRequestStream();
                stream.Write(requestBody, 0, requestBody.Length);
                WebResponse myWebResponse = request.GetResponse();
            }
            catch { }
        }
    }
}
