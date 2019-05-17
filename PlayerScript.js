#pragma strict

var Num : int = 0;
var Rum : int = 1;

function Start () {
	
}

function Update () {

    transform.position.x += Rum;

    if(transform.position.x == 22){
    Num = 1;
    }
    if(transform.position.x == -22){
    Num = 0;
    }

    switch(Num){

    case 0:
    Rum = 0.1;
    break;

    case 1:
    Rum = -0.1;
    break;

    }

}
