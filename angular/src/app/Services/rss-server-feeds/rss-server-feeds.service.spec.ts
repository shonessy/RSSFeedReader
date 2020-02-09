import { TestBed } from '@angular/core/testing';

import { RssServerFeedsService } from './rss-server-feeds.service';

describe('RssServerFeedsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RssServerFeedsService = TestBed.get(RssServerFeedsService);
    expect(service).toBeTruthy();
  });
});
