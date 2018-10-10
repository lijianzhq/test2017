<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="TestUploadFile.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="webuploader0.1.5/webuploader.css" />
    <%--<script src="webuploader0.1.5/jquery-3.3.1.min.js"></script>--%>
    <script src="webuploader0.1.5/jquery-3.3.1.js"></script>
    <script src="webuploader0.1.5/purl.js"></script>
    <script src="webuploader0.1.5/webuploader.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="uploader" class="wu-example">
            <!--用来存放文件信息-->
            <div class="uploader-list">
                <ul id="thelist"></ul>
            </div>
            <div class="btns">
                <div id="picker" class="webuploader-pick">选择文件</div>
                <button id="ctlBtn" class="btn btn-default">开始上传</button>
            </div>
        </div>
    </form>
    <!--引入JS-->
    <script type="text/javascript">
        (function (myFunc) {
            if (!window.jQuery) {
                alert("jQuery is required.");
                return;
            }
            $(function () {
                myFunc.call(null, jQuery);
            });
        })(function ($) {
            //alert($.url().attr('host'));
            var uploader = WebUploader.create({
                // swf文件路径
                swf: 'webuploader0.1.5/Uploader.swf',
                // 文件接收服务端。
                server: "FileSave.aspx",
                // 选择文件的按钮。可选。
                // 内部根据当前运行是创建，可能是input元素，也可能是flash.
                pick: '#picker',
                // 不压缩image, 默认如果是jpeg，文件上传前会压缩一把再上传！
                resize: false
            });
            uploader.on("fileQueued", function (file) {
                $("#thelist").append("<li>" + file.name + "</li>");
            });
            uploader.on("uploadError", function (file, reason) {
                alert("Upload file：{0} error,Reason：{1}".format2(file.name, reason));
                //$("#thelist").append("<li>" + file.name + "," + reason + "</li>");
            });
            uploader.on("uploadAccept", function (file, response) {
                alert("uploadAccept：" + JSON.stringify(response));
            });
            uploader.on("error", function (type) {
                alert("error：" + type);
                //if (type == "Q_TYPE_DENIED") {
                //    alert("文件不符合上传条件！");
                //}
            });
            $("#ctlBtn").click(function () {
                uploader.upload();
            });
        });


        //var str='这是一个测试的字符串：{0} {1}'.format('Hello','world');
        //或:
        //var str='这是一个测试的字符串：{str0} {str1}'.format({str0:'Hello',str1:'world'});
        //输出：这是一个测试的字符串：Hello world
        String.prototype.format2 = function (args) {
            var result = this;
            if (arguments.length > 0) {
                if (arguments.length == 1 && typeof (args) == "object") {
                    for (var key in args) {
                        if (args[key] != undefined) {
                            var reg = new RegExp("({" + key + "})", "g");
                            result = result.replace(reg, args[key]);
                        }
                    }
                }
                else {
                    for (var i = 0; i < arguments.length; i++) {
                        if (arguments[i] != undefined) {
                            var reg = new RegExp("({)" + i + "(})", "g");
                            result = result.replace(reg, arguments[i]);
                        }
                    }
                }
            }
            return result;
        };

        (function () {
            /// <summary>
            /// 引号转义符号
            /// </summary>
            String.EscapeChar = '\'';

            /// <summary>
            /// 替换所有字符串
            /// </summary>
            /// <param name="searchValue">检索值</param> 
            /// <param name="replaceValue">替换值</param> 
            String.prototype.replaceAll = function (searchValue, replaceValue) {
                var regExp = new RegExp(searchValue, "g");
                return this.replace(regExp, replaceValue);
            }

            /// <summary>
            /// 格式化字符串
            /// </summary>
            String.prototype.format = function () {
                var regexp = /\{(\d+)\}/g;
                var args = arguments;
                var result = this.replace(regexp, function (m, i, o, n) {
                    return args[i];
                });
                return result.replaceAll('%', String.EscapeChar);
            }
        })();
    </script>
</body>
</html>
