
if (window.Mediator) {
    var thenChannel = "mediator_extend_then";
    Mediator.prototype.then = function (fn) {
        this.subscribe(null, fn);
    };
    Mediator.prototype.publishThen = function (data) {
        this.publish("", data);
    };
}