console.log('hwllo World!');
function add(a:any, b:any):any;

function add(a:number, b:number): number;

function add(a: any, b:any): any {
    return a + b;
}

function largest(a:any,b:any){
    if(a<b){return b;}
    else{return a;}
}

console.log(add('world','hello'));

console.log("Largest: "+largest(10,20));