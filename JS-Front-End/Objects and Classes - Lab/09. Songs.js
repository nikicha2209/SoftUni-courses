function songs(input) {

    class Song {
        constructor(type, name, time) {
            this.type = type;
            this.name = name;
            this.time = time;
        }
    }
    let songs = [];
    let n = input[0];

    for (let index = 1; index <= n; index++) {
        let currentLine = input[index];
        let tokens = currentLine.split("_");
        [type, name, time] = tokens;
        let song = new Song(type, name, time);
        songs.push(song);
    }

    if (input[n + 1] == "all") {
        songs.forEach(song => {
            console.log(song.name);
        });
    } else {
        let filtered = songs.filter((song) => song.type==input[n+1]);

        filtered.forEach(song=>{
            console.log(song.name);
        })
    }
}

songs([3,
'favourite_DownTown_3:14',
'favourite_Kiss_4:16',
'favourite_Smooth Criminal_4:01',
'favourite']
)

