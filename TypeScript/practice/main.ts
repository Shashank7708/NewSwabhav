function dosomething(){
    for(var i=0;i<10;i++){
        console.log(i);
    }
console.log("Finally: "+i);

}
dosomething();

let a;
a=10;
a="romy";
console.log(a);


let log=(message,num)=>{
    console.log(message+'    '+num);
}

log("hello",10);
let dolog= function(message,num2){
    console.log(message+'    '+num2);
}


//Interfaces

interface Todo{
     num1:number,
     num2:number
}

let interfaceImplemet=(todo:Todo)=>{
    
}

interfaceImplemet({
    num1:10,
    num2:20
})


//Class

class A{
  private  x:number;
    y:number;
    
    a=()=>{
        console.log("This is Lamda Expression");
    }
    dothis(){
        console.log(this.x+" "+this.y);
    }
}

let q=new A();
//q.x=10;  //error
q.y=20;
q.dothis();
q.a();



//Constructor

class ConstructorEg{
   
    constructor(x?:number,y?:number){}     //this will define num x and y which can be use anywhere in code
    a=()=>{                                //"?"  shows that it is optional but it gives error in dothis();
        console.log("This is Lamda Expression");
    }
    dothis(){
       // console.log(this.x+" "+this.y);
    }
}