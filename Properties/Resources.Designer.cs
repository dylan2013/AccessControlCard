﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.2012
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessControlCard.Properties {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強型別資源類別
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AccessControlCard.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強型別資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;?xml-stylesheet type=&quot;text/xsl&quot; href=&quot;format.xsl&quot; ?&gt;
        ///&lt;ValidateRule Name=&quot;卡號及手機號碼資料&quot;&gt;
        ///  &lt;DuplicateDetection&gt;
        ///    &lt;Detector Name=&quot;學號&quot;&gt;
        ///      &lt;Field Name=&quot;學號&quot; /&gt;
        ///    &lt;/Detector&gt;
        ///    &lt;Detector Name=&quot;卡號&quot; IsImportKey=&quot;False&quot;&gt;
        ///      &lt;Field Name=&quot;卡號&quot; /&gt;
        ///    &lt;/Detector&gt;
        ///  &lt;/DuplicateDetection&gt;
        ///  &lt;FieldList&gt;
        ///    &lt;!--
        ///        系統編號(自動產生，可看不可以改)、學號、班級、座號、姓名、卡號、簡訊手機。使用者可以匯入批次修改。可以系統編號、學號做為匯入的鍵值。
        ///卡號不得重覆。
        ///        --&gt;
        ///
        ///    &lt;!-- 學生系統編號 2013/9/24 - 俊威註解
        ///    	&lt;Field Re [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        internal static string AccessControlCard {
            get {
                return ResourceManager.GetString("AccessControlCard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;?xml-stylesheet type=&quot;text/xsl&quot; href=&quot;format.xsl&quot; ?&gt;
        ///&lt;ValidateRule Name=&quot;新生卡號及手機號碼資料&quot;&gt;
        ///  &lt;DuplicateDetection&gt;
        ///    &lt;Detector Name=&quot;學生系統編號&quot;&gt;
        ///      &lt;Field Name=&quot;學生系統編號&quot;/&gt;
        ///    &lt;/Detector&gt;
        ///    &lt;Detector Name=&quot;卡號&quot; IsImportKey=&quot;False&quot;&gt;
        ///      &lt;Field Name=&quot;卡號&quot;/&gt;
        ///    &lt;/Detector&gt;
        ///  &lt;/DuplicateDetection&gt;
        ///  &lt;FieldList&gt;
        ///    &lt;Field Required=&quot;True&quot; EmptyAlsoValidate=&quot;False&quot; Name=&quot;學生系統編號&quot; Description=&quot;每一名學生都擁有獨一無二由系統編列之學生系統編號&quot;&gt;
        ///      &lt;Validate AutoCorrect=&quot;False&quot; Descrip [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        internal static string AccessControlCard_newStudent {
            get {
                return ResourceManager.GetString("AccessControlCard_newStudent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;?xml-stylesheet type=&quot;text/xsl&quot; href=&quot;format.xsl&quot; ?&gt;
        ///&lt;ValidateRule Name=&quot;卡號及手機號碼資料&quot;&gt;
        ///    &lt;DuplicateDetection&gt;
        ///
        ///        &lt;Detector Name=&quot;學生系統編號&quot;&gt;
        ///            &lt;Field Name=&quot;學生系統編號&quot; /&gt;
        ///        &lt;/Detector&gt;
        ///
        ///        &lt;Detector Name=&quot;卡號&quot; IsImportKey=&quot;False&quot;&gt;
        ///            &lt;Field Name=&quot;卡號&quot; /&gt;
        ///        &lt;/Detector&gt;
        ///
        ///    &lt;/DuplicateDetection&gt;
        ///    &lt;FieldList&gt;
        ///        &lt;!--
        ///        系統編號(自動產生，可看不可以改)、學號、班級、座號、姓名、卡號、簡訊手機。使用者可以匯入批次修改。可以系統編號、學號做為匯入的鍵值。
        ///卡號不得重覆。
        ///        --&gt; [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        internal static string AccessControlCard_StudentID {
            get {
                return ResourceManager.GetString("AccessControlCard_StudentID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;?xml-stylesheet type=&quot;text/xsl&quot; href=&quot;format.xsl&quot; ?&gt;
        ///&lt;ValidateRule Name=&quot;卡號及手機號碼資料&quot;&gt;
        ///    &lt;DuplicateDetection&gt;
        ///
        ///        &lt;Detector Name=&quot;學號&quot;&gt;
        ///            &lt;Field Name=&quot;學號&quot; /&gt;
        ///        &lt;/Detector&gt;
        ///
        ///        &lt;Detector Name=&quot;卡號&quot; IsImportKey=&quot;False&quot;&gt;
        ///            &lt;Field Name=&quot;卡號&quot; /&gt;
        ///        &lt;/Detector&gt;
        ///
        ///    &lt;/DuplicateDetection&gt;
        ///    &lt;FieldList&gt;
        ///        &lt;!--
        ///        系統編號(自動產生，可看不可以改)、學號、班級、座號、姓名、卡號、簡訊手機。使用者可以匯入批次修改。可以系統編號、學號做為匯入的鍵值。
        ///卡號不得重覆。
        ///        --&gt;
        ///
        ///     [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        internal static string AccessControlCard_StudentNumber {
            get {
                return ResourceManager.GetString("AccessControlCard_StudentNumber", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap admissions_close_128 {
            get {
                object obj = ResourceManager.GetObject("admissions_close_128", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap classmate_config_128 {
            get {
                object obj = ResourceManager.GetObject("classmate_config_128", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap e_learning_config_128 {
            get {
                object obj = ResourceManager.GetObject("e_learning_config_128", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap find {
            get {
                object obj = ResourceManager.GetObject("find", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap Import_Image {
            get {
                object obj = ResourceManager.GetObject("Import_Image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap layers_ok_64 {
            get {
                object obj = ResourceManager.GetObject("layers_ok_64", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap Text_Message_128 {
            get {
                object obj = ResourceManager.GetObject("Text_Message_128", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}