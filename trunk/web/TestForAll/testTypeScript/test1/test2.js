//let myName: string = 'Tom';
//let myAge: number = 20;
//let sentence: string = `Hello, my name is ${myName}.
//I'll be ${myAge + 1} years old next month.`;
function Test(value) {
    console.log(typeof value);
    console.log(!value && value === undefined);
}
Test(null);
Test(undefined);
Test('');
Test(undefined);
Test(0);
function Test2() {
    if (true) {
        // TDZ开始
        tmp = 'abc'; // ReferenceError
        console.log(tmp); // ReferenceError
        var tmp = // TDZ结束
         void 0; // TDZ结束
        console.log(tmp); // undefined
        tmp = 123;
        console.log(tmp); // 123
    }
}
Test2();
