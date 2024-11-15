using System;
namespace JiebaNet.Segmenter
{
    public class WordInfo
    {
        public WordInfo(string value,int position)
        {
            this.value = value;
            this.position = position;
        }
        /// <summary>
        /// 分词的内容
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 分词的初始位置
        /// </summary>
        public int position { get; set; }
    }
}
