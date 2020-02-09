import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { RSSFeed } from '@app/Models/RSSFeed';
import { Settings } from '@app/Models/Settings';

@Injectable({
  providedIn: 'root'
})
export class RssToJsonService {
  private readonly baseUrl: string;
  private headers: Headers;
  
  constructor(private http: HttpClient) {
    this.baseUrl = new Settings().rss2jsonAddress;
    this.headers = new Headers({ 
      'Access-Control-Allow-Origin' : '*',
      "Accept": "application/json",
      'Pragma': undefined, 'Cache-Control': undefined, 'X-Requested-With': undefined, 'If-Modified-Since': undefined
    });
  }

  public getFeedContent(rssAddress: string): Observable<RSSFeed> {
    const url = this.baseUrl + rssAddress;
    return this.http.get(url/*, { headers: this.headers }*/)
            .pipe(
              map(res => res as RSSFeed)
            );
  }

}
