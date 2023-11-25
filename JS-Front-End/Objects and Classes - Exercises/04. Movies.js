function movieInformation(input) {
    let movies = [];

    for(element of input){
        if (element.includes("addMovie")) {
            let name = element.split("addMovie ")[1];
            movies[name] = {};
            movies[name].name = name;
        } else if (element.includes("directedBy")) {
            let searchedMovie = element.split(" directedBy ")[0];

            if(searchedMovie in movies){
                let director = element.split(" directedBy ")[1];
                movies[searchedMovie].director = director;
            }
        } else if(element.includes(" onDate ")){
            let searchedMovie = element.split(" onDate ")[0];

            if(searchedMovie in movies){
                let date = element.split(" onDate ")[1];
                movies[searchedMovie].date = date;
            }
        }
    }

    let output = []
     for (let [key, value] of Object.entries(movies)){
         if (Object.keys(movies[key]).length !== 3){
             delete movies[key]
         } else {
             output.push(value)
             console.log(JSON.stringify(value))
        }
    }
    pars
}

movieInformation([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
    ]
    );

    

