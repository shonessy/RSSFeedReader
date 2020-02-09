import { Component, OnInit } from "@angular/core";
import { RssServerFeedsService } from "@app/Services/rss-server-feeds/rss-server-feeds.service";
import { RssServerFeed } from "@app/Models/RssServerFeed";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Component({
  selector: "app-server-feeds",
  templateUrl: "./server-feeds.component.html",
  styleUrls: ["./server-feeds.component.css"],
  animations: [appModuleAnimation()]
})
export class ServerFeedsComponent implements OnInit {

  public rssServerFeeds: RssServerFeed[];
  public createNewRssServerFeedFlag: boolean;
  public newFeedForm: FormGroup;

  constructor(
    private rssServerFeedsService: RssServerFeedsService,
    private fb: FormBuilder
  ) {
    this.rssServerFeeds = [];
    this.createNewRssServerFeedFlag = false;
  }

  async ngOnInit() {
    await this.getAllFeeds();
    this.createForm();
  }

  public createNewRssServerFeed() {
    this.createNewRssServerFeedFlag = true;
  }

  public closeCreatingNewRssServerFeed() {
    this.createNewRssServerFeedFlag = false;
    this.resetFormState();
  }

  public async save() {
    const feed = new RssServerFeed(
      this.newFeedForm.get("title").value, 
      this.newFeedForm.get("author").value, 
      this.newFeedForm.get("description").value, 
      this.newFeedForm.get("content").value
    );
    await this.rssServerFeedsService.postServerFeed(feed).toPromise();
    this.closeCreatingNewRssServerFeed();
    await this.getAllFeeds();
  }

  private async getAllFeeds() {
    this.rssServerFeeds = await this.rssServerFeedsService.getAllServerFeeds().toPromise();
  }

  private createForm() {
    this.newFeedForm = this.fb.group({
        title: ["", [Validators.required]],
        author: ["", [Validators.required]],
        description: ["", [Validators.required]],
        content: ["", [Validators.required]]
    });
  }

  private resetFormState() {
    this.newFeedForm.setValue({
      title: "",
      author: "",
      description: "",
      content: ""
    });
  }

}
