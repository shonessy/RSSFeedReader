import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Settings } from "@app/Models/Settings";
import { Observable } from "rxjs";
import { RssServerFeed } from "@app/Models/RssServerFeed";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class RssServerFeedsService {
  private readonly baseUrl: string;

  constructor(private http: HttpClient) {
    this.baseUrl = new Settings().rssServerFeedsAddress;
  }

  public getAllServerFeeds(): Observable<RssServerFeed[]> {
    const url = this.baseUrl + "/GetAll";
    return this.http.get(url)
            .pipe(
              map(res => (res as any).result.items as RssServerFeed[])
            );
  }

  public getServerFeedDetails(id: number): Observable<RssServerFeed> {
    const url = this.baseUrl + "/GetById?Id=" + id;
    return this.http.get(url)
            .pipe(
              map(res => (res as any).result as RssServerFeed)
            );
  }

  public postServerFeed(serverFeed: RssServerFeed): Observable<any> {
    const url: string = this.baseUrl + "/Create";
    return this.http.post(url, serverFeed)
            .pipe(
              map(res => res)
            );
  }

  public deleteServerFeed(id: number): Observable<any> {
    const url: string = this.baseUrl + "/Delete?Id=" + id;
    return this.http.delete(url)
            .pipe(
              map(res => res)
            );
  }
}
