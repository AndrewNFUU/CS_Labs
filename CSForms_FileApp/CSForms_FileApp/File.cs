using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSForms_FileApp
{
    public class File
    {
        #region Fields
        private string name = "";
        private string content = "";
        private long length;
        private DateTime creationTime;
        #endregion

        // що таке властивості 
        #region Propertis
        public string Name
        {
            get { 
                return name; 
            }

            set { 

                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("File name can't be empty or containn only spaces");
                }
                name = value;
            }
        }

        public long Length
        {
            get
            {
                return length;
            }

            private set { 
                if (length >= 0) {
                    length = value;
                } else {
                    throw new ArgumentException("File size cannot negative length.");
                }
            }
        }

        public DateTime CreationTime
        {
            get {
                return creationTime;
            }

            set {
                creationTime = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                Length = content.Length;
            }
        }

        public static int FileCount { get; set; } = 0;
        #endregion


        #region Constructors
        public File() {
            Name = "no_name";
            CreationTime = DateTime.Now;
            FileCount++;
            Content = string.Empty;
        }

        // nullable - 
        public File(string newName, string newContent, DateTime? newCreationTime = null) { 
            Name = newName;
            CreationTime = newCreationTime ?? DateTime.Now;
            Content = newContent;
            FileCount++;
        }
        #endregion


        #region Functions
        public void AppendData(string data)
        {
            Content += data;
        }


        public override string ToString()
        {
            return $"File: {Name}, \n Length: {Length}, \n" +
                $"Date: {creationTime.Day}.{creationTime.Month}.{creationTime.Year}\n";
        }
        #endregion
    }
}
