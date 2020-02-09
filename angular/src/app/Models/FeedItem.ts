import { FeedEnclosure } from './FeedEnclosure';

export class FeedItem {
    title: string;
    pubDate: Date;
    link: string;
    guid: string;
    author: string;
    thumbnail: string;
    description: string;
    content: string;
    categories: string[];
    enclosure: FeedEnclosure;
}
