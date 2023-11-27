function editElement(ref, matcher, replacer) {
    let text = ref.textContent;
    text = text.replace(new RegExp(matcher, 'g'), replacer);
    ref.textContent = text;
}