using System.Collections.Generic;

namespace Main
{
    /// <summary>
    /// 返回数据
    /// </summary>
    public class ResModel
    {
        /// <summary>
        /// 请求状态(0成功1失败)
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 成功数据，参考data返回值
        /// </summary>
        public DataModel data { get; set; }
    }
    /// <summary>
    /// 返回Data数据
    /// </summary>
    public class DataModel
    {
        /// <summary>
        /// 相册标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 文章id
        /// </summary>
        public int doc_id { get; set; }
        /// <summary>
        /// 作者名称
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 图片数组
        /// </summary>
        public List<PicturesModel> pictures { get; set; }
    }
    /// <summary>
    /// 图片实体数据
    /// </summary>
    public class PicturesModel
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        public string img_src { get; set; }
        /// <summary>
        /// 图片宽度
        /// </summary>
        public int img_width { get; set; }
        /// <summary>
        /// 图片高度
        /// </summary>
        public int img_height { get; set; }
        /// <summary>
        /// 图片大小
        /// </summary>
        public int img_size { get; set; }
    }
}
