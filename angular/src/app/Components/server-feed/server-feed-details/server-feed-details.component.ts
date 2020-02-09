import { Component, OnInit } from "@angular/core";
import { RssServerFeedsService } from "@app/Services/rss-server-feeds/rss-server-feeds.service";
import { Router, ActivatedRoute, Params } from "@angular/router";
import { RssServerFeed } from "@app/Models/RssServerFeed";
import { appModuleAnimation } from "@shared/animations/routerTransition";

@Component({
  selector: "app-server-feed-details",
  templateUrl: "./server-feed-details.component.html",
  styleUrls: ["./server-feed-details.component.css"],
  animations: [appModuleAnimation()]
})
export class ServerFeedDetailsComponent implements OnInit {

  private feedId: number;
  private feed: RssServerFeed;
  constructor(
    private rssServerFeedsService: RssServerFeedsService,
    private _router: Router,
    private _activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    this._activatedRoute.params.subscribe((params: Params) => {
      this.feedId = params['id'];
      this.loadFeed();
    });
  }

  public async deleteFeed() {
    if (confirm("Are you sure you want to delete this feed?")) {
      await this.rssServerFeedsService.deleteServerFeed(this.feedId).toPromise();
      this.backToFeeds();
    }
  }

  private async loadFeed() {
    this.feed = await this.rssServerFeedsService.getServerFeedDetails(this.feedId).toPromise();
  }

  private backToFeeds() {
    this._router.navigate(['app/server-feeds']);
  }
}
