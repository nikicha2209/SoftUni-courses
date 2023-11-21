function meetings(input){
    let meetings = {};
    for(const line of input){
        tokens = line.split(" ");
        if(meetings.hasOwnProperty(tokens[0])){
            console.log(`Conflict on ${tokens[0]}!`);
        } else{
            meetings[tokens[0]] = tokens[1];
            console.log(`Scheduled for ${tokens[0]}`);
        }
    };

    for (let [key, value] of Object.entries(meetings)){
        console.log(`${key} -> ${value}`)
    }
}
