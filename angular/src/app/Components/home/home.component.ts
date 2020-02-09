import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { RssToJsonService } from '@app/Services/rss-to-json/rss-to-json.service';
import { Settings } from '@app/Models/Settings';
import { RSSFeed } from '@app/Models/RSSFeed';

@Component({
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
    animations: [appModuleAnimation()]
})
export class HomeComponent implements AfterViewInit {

    public rssFeed: RSSFeed;
    private settings: Settings;
    private newsUrl: string;
    private newsSite: string;
    
  
    constructor(private rssToJsonService: RssToJsonService) { 
      this.rssFeed = null;
      this.settings = new Settings();
      this.newsUrl = this.settings.nasaRssAddress;
      this.newsSite = 'nasa';
    }

    ngAfterViewInit(): void {
        this.refreshFeed();
    }

    public async refreshFeed() {
        this.rssFeed = null;
        this.rssFeed = await this.rssToJsonService.getFeedContent(this.newsUrl).toPromise();
      }
    
      public changeNewsFeed(newsSite: string) {
        // TODO: Nemanja - uvesti enumeraciju...
        this.newsSite = newsSite;
        if (newsSite === 'nasa') {
          this.newsUrl = this.settings.nasaRssAddress;
        }
        else if (newsSite === 'cnn') {
          this.newsUrl = this.settings.cnnRssAddress;
        }
        else if (newsSite === 'sporting-news') {
          this.newsUrl = this.settings.sportingNewsRssAddress;
        }
        this.refreshFeed();
      }
}
