import {golfCoach} from "./GolfCoach";
import {cricketCoach} from "./CricketCoach"
import {Coach} from "./Coach"

let golf=new golfCoach();
let cricket=new cricketCoach();

let coachArray:Coach[]=[];
coachArray.push(golf);
coachArray.push(cricket);
for(let temp of coachArray){
    console.log(temp.getWorkout());
}