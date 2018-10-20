
//var p = new Promise(function (resolve, reject) {
//    //用setTimeout模拟异步操作
//    setTimeout(function () {
//        console.log('第一个Promise执行完成');
//        resolve('第一个Promise');
//    }, 2000);
//});

//function test() {
//    return new Promise(function (resolve, reject) {
//        //resolve("lijian");
//        reject("zhq");
//    });
//};


//then和catch
//test().then(function (result) {
//    console.log(result);
//    console.dir(Promise);
//}).catch(function (message) {
//    console.log(message);
//});

//then，两个参数
//test().then(function (result) {
//    console.log(result);
//    console.dir(Promise);
//}, function (message) {
//    console.log(message);
//});


//********************promise重写ajax模式********************
var getJSON = function (url) {
    return new Promise(function (resolve, reject) {
        var XHR = new XMLHttpRequest();
        XHR.open('GET', url, true);
        XHR.send();

        XHR.onreadystatechange = function () {
            if (XHR.readyState !== 4) return;

            if (XHR.status === 200) {
                resolve(XHR.response);
            }
            else {
                reject(XHR.status + XHR.statusText);
            }
        }
    });
};

getJSON("http://hq.tigerbrokers.com/fundamental/finance_calendar/getType/2017-02-26/2017-06-10").then(function (result) {
    console.log(result);
}).catch(function (message) {
    console.log(message);
});
//********************end promise重写ajax模式********************
