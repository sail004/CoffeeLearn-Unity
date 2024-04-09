document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("addTopic").addEventListener("click", function () {
        var topicsDiv = document.getElementById("topics");
        var topicCount = topicsDiv.children.length + 1;

        var topicDiv = document.createElement("div");
        topicDiv.classList.add("topic");

        var label = document.createElement("label");
        label.htmlFor = "topic" + topicCount;
        label.textContent = "Название темы " + topicCount + ":";

        var input = document.createElement("input");
        input.type = "text";
        input.id = "topic" + topicCount;
        input.name = "topic[]";
        input.required = true;

        var contentDiv = document.createElement("div");
        contentDiv.classList.add("content");

        var contentLabel = document.createElement("label");
        contentLabel.htmlFor = "content" + topicCount;
        contentLabel.textContent = "Content:";

        var textarea = document.createElement("textarea");
        textarea.id = "content" + topicCount;
        textarea.name = "content[]";
        textarea.required = true;

        var addLectureBtn = document.createElement("button");
        addLectureBtn.type = "button";
        addLectureBtn.classList.add("addLecture");
        addLectureBtn.textContent = "Добавить лекцию";

        var addTestBtn = document.createElement("button");
        addTestBtn.type = "button";
        addTestBtn.classList.add("addTest");
        addTestBtn.textContent = "Добавить тест";

        contentDiv.appendChild(contentLabel);
        contentDiv.appendChild(textarea);
        contentDiv.appendChild(document.createElement("br"));
        contentDiv.appendChild(addLectureBtn);
        contentDiv.appendChild(addTestBtn);

        topicDiv.appendChild(label);
        topicDiv.appendChild(input);
        topicDiv.appendChild(document.createElement("br"));
        topicDiv.appendChild(contentDiv);

        topicsDiv.appendChild(topicDiv);
    });

    document.getElementById("courseForm").addEventListener("click", function (event) {
        if (event.target.classList.contains("addLecture")) {
            var contentDiv = event.target.parentNode;
            var textarea = document.createElement("textarea");
            textarea.name = "content[]";
            textarea.required = true;
            contentDiv.insertBefore(textarea, event.target);
            contentDiv.insertBefore(document.createElement("br"), event.target);
        } else if (event.target.classList.contains("addTest")) {
            var contentDiv = event.target.parentNode;
            var textarea = document.createElement("textarea");
            textarea.name = "content[]";
            textarea.required = true;
            contentDiv.insertBefore(textarea, event.target);
            contentDiv.insertBefore(document.createElement("br"), event.target);
        }
    });
});