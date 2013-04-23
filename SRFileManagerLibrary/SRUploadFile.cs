using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.IO;
using System.Collections;
using LitJson;

namespace SRFileManagerLibrary
{
    /// <summary>
    /// 上传文件类
    /// </summary>
    public class SRUploadFile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context">Http上下文</param>
        /// <param name="fileKey">上传文件的表单名</param>
        public SRUploadFile(HttpContext context,string fileKey)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = "file";
            FileTitle = "";
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = 4194304;
            SetStatus(0,"初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey,string fileType)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = "";
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = 4194304;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType,string fileTitle)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = 4194304;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle,string fileFolder )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = 4194304;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle, string fileFolder ,Hashtable ht)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable = ht;
            MaxSize = 4194304;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle, string fileFolder, Hashtable ht,int maxSize)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable = ht;
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle, string fileFolder, Hashtable ht, int maxSize, bool isCreatFolder)
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable = ht;
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = isCreatFolder;
        }

        public SRUploadFile(HttpContext context, string fileKey, int maxSize )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = "file";
            FileTitle = "";
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey,   string fileTitle , int maxSize )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = "file";
            FileTitle = fileTitle;
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }

        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle,  int maxSize )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = "/Files/";
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }

        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle, string fileFolder,  int maxSize )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable.Add("image", "gif,jpg,jpeg,png,bmp");
            ExtTable.Add("flash", "swf,flv");
            ExtTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            ExtTable.Add("file", "doc,docx,xls,xlsx,ppt,pptx,htm,html,txt,zip,rar,gz,7z,bz2,pdf");
            MaxSize = maxSize;
            SetStatus(0, "初始状态");
            IsCreatFolder = true;
        }
        public SRUploadFile(HttpContext context, string fileKey, string fileType, string fileTitle, string fileFolder, Hashtable ht, bool isCreatFolder )
        {
            Context = context;
            PostFile = context.Request.Files[fileKey];
            FileType = fileType;
            FileTitle = fileTitle;
            FileFolder = fileFolder;
            ExtTable = ht;
            MaxSize = 4194304;
            SetStatus(0, "初始状态");
            IsCreatFolder = isCreatFolder;
        }
        #region 定义变量
        /// <summary>
        /// 文件题目
        /// </summary>
        public string FileTitle { get; set; }
        /// <summary>
        /// 文件名,带文件扩展名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件扩展名，带"."
        /// </summary>
        public string FileExt { get; set; }
        /// <summary>
        /// 文件保存路径，相对于应用程序域，不包含文件名
        /// </summary>
        public string FileFolder { get; set; }
        /// <summary>
        /// 文件保存的路径，相对于应用程序域，包含文件名
        /// </summary>
        public string FilePath { get; set; }
        /// <summary>
        /// 文件保存的物理在的文件夹
        /// </summary>
        public string DiskFolder { get; set; }
        /// <summary>
        /// 文件保存的物理路径
        /// </summary>
        public string DiskPath { get; set; }
        /// <summary>
        /// HTTP上下文
        /// </summary>
        public HttpContext Context { get; set; }

        /// <summary>
        /// 定义允许上传的文件扩展名,
        /// </summary>
        public Hashtable ExtTable { get; set; }
        /// <summary>
        /// 上传文件大小最大值
        /// </summary>
        public int MaxSize { get; set; }
        /// <summary>
        /// http上传的文件
        /// </summary>
        public HttpPostedFile PostFile {get;set;}
        /// <summary>
        /// 当前处理状态
        /// </summary>
        public Hashtable StepStatus { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// 上传文件夹不存在时，是否自动创建目录
        /// </summary>
        public bool IsCreatFolder { get; set; }
        #endregion

        #region 定义方法
        /// <summary>
        /// 保存文件
        /// </summary>
        public Hashtable SaveFile()
        {
            if(PostFile==null){
                SetStatus(2,"没有选择上传文件");
                return StepStatus;
            }
            //设置文件名
            FileName = PostFile.FileName;
            //文件扩展名
            FileExt = Path.GetExtension(FileName).ToLower();
            //是否重命名
            if (!(FileTitle == "" || FileTitle == ""))
            {
                //重命名
                FileName = FileTitle + FileExt;
            }
            //文件物理路径
            DiskFolder = Context.Server.MapPath(FileFolder);
            //文件存储路径
            FilePath = FileFolder + FileName ;
            DiskPath = DiskFolder +FileName ;

            if (String.IsNullOrEmpty(FileExt) || Array.IndexOf(((String)ExtTable[FileType]).Split(','), FileExt.Substring(1).ToLower()) == -1)
            {
                SetStatus(2,"上传文件扩展名是不允许的扩展名。\n只允许" + ((String)ExtTable[FileType]) + "格式。");
                return StepStatus;
            }
            if (PostFile.InputStream == null || PostFile.InputStream.Length > MaxSize)
            {
                SetStatus(2, "上传文件大小不能超过"+MaxSize/(1024*1024)+"M");
                return StepStatus;
            }
            if (!Directory.Exists(DiskFolder))
            {
                SetStatus(2, "上传目录不存在。");
                if (IsCreatFolder)
                {
                    try
                    {
                        //创建文件夹
                        Directory.CreateDirectory(DiskFolder);
                    }
                    catch (Exception ex){
                        SetStatus(2, "创建目录失败，您的应用程序可能没有权限在服务器上创建目录。错误信息：" + ex.Message); 
                        return StepStatus;
                    }
                }
                else
                {
                    return StepStatus;
                }
            }

            try
            {
                PostFile.SaveAs(DiskPath);
                SetStatus(1, "保存成功!");
            }
            catch (Exception ex){
                SetStatus(2, "保存文件失败，您的应用程序可能没有权限在服务器上操作文件。错误信息：" + ex.Message);
                return StepStatus;
            }
            return StepStatus;
        }
        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="st">状态值，0，为未知，1为成功，2为错误</param>
        /// <param name="msg">状态信息</param>
        public void SetStatus(int st, string msg)
        {
            StepStatus["status"] = st;
            StepStatus["msg"] = msg;
        }

        #endregion

    }
}
