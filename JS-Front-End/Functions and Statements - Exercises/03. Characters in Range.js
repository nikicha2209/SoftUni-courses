function charactersRange(firstCharacter, secondCharacter) {
    let start = firstCharacter.charCodeAt();
    let end = secondCharacter.charCodeAt();
    let result = '';

    if (end < start) {
        start = secondCharacter.charCodeAt();
        end = firstCharacter.charCodeAt();
    }

    let elements = [];

    for (let index = start + 1; index < end; index++) {
        result += `${String.fromCharCode(index)} `;
    }

    console.log(result);
}

charactersRange('#', ':')
