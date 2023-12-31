function attachEvents() {
    let baseUrl = "http://localhost:3030/jsonstore/blog";
    let loadPostsButton = document.getElementById("btnLoadPosts");
    let postsSelect = document.getElementById("posts");
    let postTitle = document.getElementById("post-title");
    let postBody = document.getElementById("post-body");
    let postComments = document.getElementById("post-comments");

    loadPostsButton.addEventListener("click", e => {
        e.preventDefault();

        // Clear previous data
        postsSelect.innerHTML = "";
        postTitle.textContent = "Post Details";
        postBody.textContent = "";
        postComments.innerHTML = "";

        fetch(baseUrl + "/posts")
            .then(res => res.json())
            .then(data => {
                for (const [key, object] of Object.entries(data)) {
                    const { body, id, title } = object;
                    let option = document.createElement("option");
                    option.setAttribute("value", id);
                    option.textContent = title;
                    postsSelect.appendChild(option);
                }
            })
    })

    let viewPosts = document.getElementById("btnViewPost");
    viewPosts.addEventListener("click", e => {
        e.preventDefault();

        let selectedPostId = postsSelect.value;
        postComments.innerHTML = "";

        fetch(`${baseUrl}/posts/${selectedPostId}`)
            .then(res => res.json())
            .then(post => {
                postTitle.textContent = post.title;
                postBody.textContent = post.body;
            })
            .catch(err => console.log("Error loading post details:", err));

        fetch(`${baseUrl}/comments`)
            .then(res => res.json())
            .then(data => {
                for (const [key, object] of Object.entries(data)) {
                    let { id, postId, text } = object;

                    if (postId === selectedPostId) {
                        let commentItem = document.createElement("li");
                        commentItem.textContent = text;
                        postComments.appendChild(commentItem);
                    }
                }
            })
    })
}

attachEvents();