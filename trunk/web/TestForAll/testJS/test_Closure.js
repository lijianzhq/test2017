
window.onload = function () {

    //以下案例，输出10；
    //var a = [];
    //for (var i = 0; i < 10; i++) {
    //    a[i] = function () {
    //        var k = i;
    //        console.log(k);
    //    };
    //}
    //a[6](); // 10


    //以下案例，采用了闭包
    //var a = [];
    //for (var i = 0; i < 10; i++) {
    //    (function (input) {
    //        a[input] = function () {
    //            console.log(input);
    //        };
    //    })(i);
    //}
    //a[6](); // 6

    //以下案例，输出10，证明了i其实并没有被释放，都是全局有效的
    //var a = [];
    //for (var i = 0; i < 10; i++) {
    //    a[i] = function () {
    //        console.log(i);
    //    };
    //}
    //a[6](); // 10
    //console.log(i);

    //以下案例，输出undefined，证明了i其实并没有被释放，都是全局有效的
    //var a = [];
    //for (let i = 0; i < 10; i++) {
    //    a[i] = function () {
    //        console.log(i);
    //    };
    //}
    //a[6](); //6
    //console.log(i);

    //var 和 let的区别
    // var 的情况
    console.log(foo); // 输出undefined
    var foo = 2;
    // let 的情况
    console.log(bar); // 报错ReferenceError
    let bar = 2;

    //以下案例，只输出一次name值
    //function a() {    //    var name = "追梦子";    //    function b() {    //        console.log(name);     //    }    //    b();    //}    //a();
};