var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.setid = function (id1) {
        this._id1 = id1;
    };
    Person.prototype.getid = function () {
        return this._id1;
    };
    Person.prototype.setname = function (n) {
        this._name = n;
    };
    Person.prototype.getname = function () {
        return this._name;
    };
    return Person;
}());
var person = new Person();
person.setid(10);
person.setname('Rahul');
console.log("id:" + person.getid());
console.log(" name: " + person.getname());
