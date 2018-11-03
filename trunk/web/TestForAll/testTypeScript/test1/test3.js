
(function () {

    //测试slice方法
    //var str = "lijian";
    //console.log(str.slice(0));
    //console.log(str.slice(0, -1));

    //测试toFixed()方法
    //var num = 100;
    //console.log(num.toFixed(2));
    //console.log(num.toFixed(3));

    //测试数组copyWinthin
    // var data = [1, 2, 3, 4, 5];
    // data.copyWithin(0, 3);  // [4, 5, 3, 4, 5]
    // data.copyWithin(0, 3, 4);  // [4, 2, 3, 4, 5]
    // console.log(data);

    // -2相当于3号位，-1相当于4号位
    //[1, 2, 3, 4, 5].copyWithin(0, -2, -1);


    //如何控制一秒钟内最多点击一次，先来看使用普通的 JavaScript：
    // var count = 0;
    // var rate = 1000;
    // var lastClick = Date.now() - rate;
    // var button = document.querySelector('button');
    // button.addEventListener('click', () => {
    //     if (Date.now() - lastClick >= rate) {
    //         console.log(`Clicked ${++count} times`);
    //         lastClick = Date.now();
    //     }
    // });

    //rxjs版本
    var button = document.querySelector('button');
    Rx.Observable.fromEvent(button, 'click')
      .throttleTime(1000)
      .scan(count => count + 1, 0)
      .subscribe(count => console.log(`Clicked ${count} times`));
})();


