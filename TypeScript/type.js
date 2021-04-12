console.log('hwllo World!');
function add(a, b) {
    return a + b;
}
function largest(a, b) {
    if (a < b) {
        return b;
    }
    else {
        return a;
    }
}
console.log(add('world', 'hello'));
console.log("Largest: " + largest(10, 20));
