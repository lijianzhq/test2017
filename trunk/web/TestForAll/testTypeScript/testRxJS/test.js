const { Observable, Subject, ReplaySubject, from, of, range, Rx, fromEvent } = rxjs;
const { map, filter, switchMap } = rxjs.operators;

//range(1, 200)
//    .pipe(filter(x => x % 2 === 1), map(x => x + x))
//    .subscribe(x => console.log(x));

var button = document.body;
console.log(button);
fromEvent(button, 'click')
    .subscribe(() => console.log('Clicked!'));