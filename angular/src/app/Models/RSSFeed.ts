import { FeedInfo } from './FeedInfo';
import { FeedItem } from './FeedItem';

export class RSSFeed {
    status: string;
    feed: FeedInfo;
    items: FeedItem[];
}
