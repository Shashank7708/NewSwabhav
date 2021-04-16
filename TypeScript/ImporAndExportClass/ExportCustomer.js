"use strict";
exports.__esModule = true;
exports.Customer = void 0;
var Customer = /** @class */ (function () {
    function Customer(firstname, lastname) {
        this._firstname = firstname;
        this._lastname = lastname;
    }
    Object.defineProperty(Customer.prototype, "firstname", {
        get: function () {
            return this._firstname;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Customer.prototype, "lastname", {
        get: function () {
            return this._lastname;
        },
        enumerable: false,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
