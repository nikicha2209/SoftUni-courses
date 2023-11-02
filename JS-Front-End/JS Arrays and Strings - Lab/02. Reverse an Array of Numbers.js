function solve(n, array){
    let elements = array.slice(0,n);
    let reversed = elements.reverse();
    console.log(reversed.join(" "));
}

solve(3, [10, 20, 30, 40, 50]);