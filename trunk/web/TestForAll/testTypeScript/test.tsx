class UserDetails {

    age: number;

    constructor(age: number) {
        this.age = age;
    }
}

var user = new UserDetails(30);
console.log(user.age);