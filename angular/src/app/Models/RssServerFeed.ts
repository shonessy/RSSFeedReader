export class RssServerFeed {
    id: number;
    title: string;
    pubDate: Date;
    author: string;
    description: string;
    content: string;

    constructor(title: string, author: string, description: string, content: string) {
        this.title = title;
        this.author = author;
        this.description = description;
        this.content = content;
    }
}

