<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="TestUploadFile.demo" %>

<!DOCTYPE html>
<html lang="zh-CN">
<head>
    <meta charset="UTF-8">
    <title>WebUploader演示</title>
    <link href="webuploader0.1.5/webuploader.css" rel="stylesheet" />
    <script src="webuploader0.1.5/jquery-3.3.1.js"></script>
    <script src="webuploader0.1.5/webuploader.js"></script>
    <script src="upload.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#btn_test_post").click(function () {
                //$.post("MergeFiles.ashx", { guid: "123", fileExt: ".mtv" })
                //    .success(
                //        function (data) {
                //            data = $.parseJSON(data);
                //            if (data.hasError) {
                //                alert('文件合并失败！');
                //            } else {
                //                alert(decodeURIComponent(data.savePath));
                //            }
                //        })
                //    .error(function () { alert("error"); })
                //    .ajaxError(function () {
                //        alert("ajaxerror");
                //    });
                 jQuery.ajax({
                    url: "/Handle/Do.aspx",
                    type: "post",
                    data: { id: '0' },
                    dataType: "json",
                    success: function(msg) {
                        alert(msg);
                    },
                    error: function(XMLHttpRequest, textStatus, errorThrown) {
                        alert(XMLHttpRequest.status);
                        alert(XMLHttpRequest.readyState);
                        alert(textStatus);
                    },
                    complete: function(XMLHttpRequest, textStatus) {
                        this; // 调用本次AJAX请求时传递的options参数
                    }
                });
            });
        });
    </script>
</head>
<body>
    <div>
        <button id="btn_test_post">测试</button>
    </div>
    <div id="wrapper">
        <div id="container">
            <!--头部，相册选择和格式选择-->
            <div id="uploader">
                <div class="queueList">
                    <div id="dndArea" class="placeholder">
                        <div id="filePicker"></div>
                    </div>
                </div>
                <div class="statusBar" style="display: none;">
                    <div class="progress">
                        <span class="text">0%</span>
                        <span class="percentage"></span>
                    </div>
                    <div class="info"></div>
                    <div class="btns">
                        <div id="filePicker2"></div>
                        <div class="uploadBtn">开始上传</div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</body>
</html>
