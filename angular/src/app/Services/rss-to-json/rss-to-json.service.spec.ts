import { TestBed } from '@angular/core/testing';

import { RssToJsonService } from './rss-to-json.service';

describe('RssToJsonService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RssToJsonService = TestBed.get(RssToJsonService);
    expect(service).toBeTruthy();
  });
});
