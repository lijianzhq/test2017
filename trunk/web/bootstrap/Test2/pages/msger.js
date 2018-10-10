(function ($, undefine) {
    $.Msger = function () {
        var info = {};
        info.type = arguments[0] || "";
        info.title = arguments[1] || "";
        info.content = arguments[2] || "";
        info.content = arguments[2] || "";
        info.callBack = arguments[3] || "";
        var _msgD = {};
        var a = $("<div></div>").addClass("modal fade"); //model
        var b = $("<div></div>").addClass("modal-dialog modal-sm").appendTo(a); //dialog
        var c = $("<div></div>").addClass("modal-content").appendTo(b); //content
        var dh = $("<div></div>").addClass("modal-header").appendTo(c); //title
        var dc = $("<div></div>").addClass("modal-body").appendTo(c); //content
        var df = $("<div></div>").addClass("modal-footer").appendTo(c); //footter
        $("body").append(a); //添加到body
        _a[info.type].call(info, dh, dc, df, a);
        a.on("hidden.bs.modal", function () {
            a.remove();
        });
    };
    var _a = {
        alert: function () {
            var dh = arguments[0];
            var dc = arguments[1];
            var df = arguments[2];
            var a = arguments[3];
            var info = this;
            if (!info.callBack) {
                dh.html(info.title);
                dc.html(info.content);
                $("<button></button>").addClass("btn btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                });
            } else {
                ///先这样写 后面还要修改 要添加对类型的显示
                dh.html(info.title);
                dc.html(info.content);
                $("<button></button>").addClass("btn btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                });
            }
            a.modal({
                width: 500,
                backdrop: 'static'
            });
        },
        confirm: function () {
            var dh = arguments[0];
            var dc = arguments[1];
            var df = arguments[2];
            var a = arguments[3];
            var info = this;
            dh.html(info.title);
            dc.html(info.content);
            if (info.callBack) {

                $("<button></button>").addClass("btn btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                    info.callBack(true);
                });
                $("<button></button>").addClass("btn btn-default").attr({
                    "data-dismiss": "modal"
                }).html("取消").appendTo(df).click(function () {
                    a.modal('hide');
                    info.callBack(false);
                });
            } else {
                ///先这样写 后面还要修改 要添加对类型的显示
                $("<button></button>").addClass("btn btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                });
                $("<button></button>").addClass("btn btn-default").attr({
                    "data-dismiss": "modal"
                }).html("取消").appendTo(df).click(function () {
                    a.modal('hide');
                });
            }
            a.modal({
                width: 500,
                backdrop: 'static'
            });

        },
        promt: function () {
            var dh = arguments[0];
            var dc = arguments[1];
            var df = arguments[2];
            var a = arguments[3];
            var info = this;
            dh.append($("<h6></h6>").html(info.title));
            //              if(info.content){
            //                  dc.html(info.content);
            //              }
            var i = $("<input type='text'/>").addClass("form-control");
            dc.append(i)
            info.callBack = info.content;
            if (info.callBack) {
                $("<button></button>").addClass("btn btn-sm btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                    info.callBack(i.val(), true);

                });
                $("<button></button>").addClass("btn btn-sm btn-default").attr({
                    "data-dismiss": "modal"
                }).html("取消").appendTo(df).click(function () {
                    a.modal('hide');
                    info.callBack(i.val(), false);
                });
            } else {
                ///先这样写 后面还要修改 要添加对类型的显示
                $("<button></button>").addClass("btn btn-sm btn-primary").attr({
                    "data-dismiss": "modal"
                }).html("确定").appendTo(df).click(function () {
                    a.modal('hide');
                });
                $("<button></button>").addClass("btn btn-sm btn-default").attr({
                    "data-dismiss": "modal"
                }).html("取消").appendTo(df).click(function () {
                    a.modal('hide');
                });
            }
            a.modal({
                width: 500,
                backdrop: 'static'
            });

        }
    }

})(jQuery);