function songs(input) {

    class Song {
        constructor(type, name, time) {
            this.type = type;
            this.name = name;
            this.time = time;
        }
    }
    let songs = [];
    let n = input.shift();
    let typeSong = input.pop();

    for (let index = 0; index < n; index++) {
        let [type, name, time] = input[index].split("_") ;
        let song = new Song(type, name, time);
        songs.push(song);
    }

    if (typeSong == "all") {
        songs.forEach(song => {
            console.log(song.name);
        });
    } else {
        let filtered = songs.filter((song) => song.type==typeSong);

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

