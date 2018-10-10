<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo1.aspx.cs" Inherits="TestUploadFile.demos.demo1" %>

<!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />  
    <title></title>  
    <script src="UploadResource/jquery-1.7.1.min.js"></script>  
    <link href="UploadResource/webuploader.css" rel="stylesheet" />  
    <script src="UploadResource/webuploader.js"></script>  
    <script type="text/javascript">  
  
        // 文件上传  
        jQuery(function () {  
            var $ = jQuery,  
                $list = $('#thelist'),  
                $btn = $('#ctlBtn'),  
                state = 'pending',  
                uploader;  
  
            uploader = WebUploader.create({  
  
                // 不压缩image  
                resize: false,  
  
                // swf文件路径  
                swf: 'UploadResource/Uploader.swf',  
  
                // 文件接收服务端。  
                server: '/fileSave.ashx',  
  
                // 选择文件的按钮。可选。  
                // 内部根据当前运行是创建，可能是input元素，也可能是flash.  
                pick: '#picker'  
            });  
  
            // 当有文件添加进来的时候  
            uploader.on('fileQueued', function (file) {  
                $list.append('<div id="' + file.id + '" class="item">' +  
                    '<h4 class="info">' + file.name + '</h4>' +  
                    '<p class="state">等待上传...</p>' +  
                '</div>');  
            });  
  
            // 文件上传过程中创建进度条实时显示。  
            uploader.on('uploadProgress', function (file, percentage) {  
                var $li = $('#' + file.id),  
                    $percent = $li.find('.progress .progress-bar');  
  
                // 避免重复创建  
                if (!$percent.length) {  
                    $percent = $('<div class="progress progress-striped active">' +  
                      '<div class="progress-bar" role="progressbar" style="width: 0%">' +  
                      '</div>' +  
                    '</div>').appendTo($li).find('.progress-bar');  
                }  
  
                $li.find('p.state').text('上传中');  
  
                $percent.css('width', percentage * 100 + '%');  
            });  
  
            uploader.on('uploadSuccess', function (file) {  
                $('#' + file.id).find('p.state').text('已上传');  
            });  
  
            uploader.on('uploadError', function (file) {  
                $('#' + file.id).find('p.state').text('上传出错');  
            });  
  
            uploader.on('uploadComplete', function (file) {  
                $('#' + file.id).find('.progress').fadeOut();  
            });  
  
            uploader.on('all', function (type) {  
                if (type === 'startUpload') {  
                    state = 'uploading';  
                } else if (type === 'stopUpload') {  
                    state = 'paused';  
                } else if (type === 'uploadFinished') {  
                    state = 'done';  
                }  
  
                if (state === 'uploading') {  
                    $btn.text('暂停上传');  
                } else {  
                    $btn.text('开始上传');  
                }  
            });  
  
            $btn.on('click', function () {  
                if (state === 'uploading') {  
                    uploader.stop();  
                } else {  
                    uploader.upload();  
                }  
            });  
        });  
    </script>  
</head>  
<body>  
    <div id="uploader" class="wu-example">  
        <div id="thelist" class="uploader-list"></div>  
        <div class="btns">  
            <div id="picker">选择文件</div>  
            <button id="ctlBtn" class="btn btn-default">开始上传</button>  
  
        </div>  
    </div>  
</body>  
</html>  
