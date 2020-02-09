import { Component, OnInit, Input } from "@angular/core";
import { FeedItem } from "@app/Models/FeedItem";

@Component({
  selector: 'app-feed-card',
  templateUrl: "./feed-card.component.html",
  styleUrls: ["./feed-card.component.css"]
})
export class FeedCardComponent implements OnInit {

  @Input() newsSite: string;
  @Input() feedItem: FeedItem;
  
  constructor() { }

  ngOnInit() { }
}
