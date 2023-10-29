function solve(years){
    if(years>=0 && years<3){
        console.log("baby");
    } else if (years>=3 && years < 14){
        console.log("child");
    } else if(years>=14 && years <20){
        console.log("teenager");
    } else if(years>=19 && years<66){
        console.log("adult")
    } else if(years>=66){
        console.log("elder")
    } else{
        console.log("out of bounds")
    }
}

solve(15)
