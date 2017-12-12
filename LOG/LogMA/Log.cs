using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LogMA
{
    /*
     * https://www.facebook.com/groups/gameprogramerhacker/
     * MUHAMMED KANDEMİR
     */
    public class Log
    {
        #region Constructs
        public Log(string[] columns, string fileSaveDirectory, string fileStartName, string fileDateFormat)
        {
            this.Columns = columns;
            this.FileSaveDirectory = fileSaveDirectory;
            this.FileStartName = fileStartName;
            this.FileDateFormat = fileDateFormat;
        }
        #endregion

        #region Variables
        public readonly string SplitChar = ",";
        string[] columns = null;
        public string[] Columns
        {
            get
            {
                return columns;
            }
            set
            {
                columns = value;
                ColumnsStr = join(columns);
            }
        }
        public string ColumnsStr { get; private set; }

        public string FileDateFormat { get; set; }
        public string FileStartName { get; set; }
        public string FileSaveDirectory { get; set; }

        public string FilePath
        {
            get
            {
                return Path.Combine(FileSaveDirectory, FileStartName + DateTime.Now.ToString(FileDateFormat) + ".csv");
            }
        }
        #endregion

        #region Methods
        public void Add(params string[] row)
        {
            var _existsFile = File.Exists(this.FilePath);
            using (FileStream _fs = new FileStream(this.FilePath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter _writer = new StreamWriter(_fs))
                {
                    if (!_existsFile)
                        _writer.WriteLine(ColumnsStr);
                    _writer.WriteLine(join(row));
                }
            }
        }
        private string join(IEnumerable<string> datas)
        {
            return string.Join(SplitChar, datas.Select(o => "\"" + o.Replace("\"", "\"\"") + "\"").ToArray());
        }
        #endregion
    }
}
