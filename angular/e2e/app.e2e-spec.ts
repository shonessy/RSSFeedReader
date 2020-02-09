import { RSSFeedReaderTemplatePage } from './app.po';

describe('RSSFeedReader App', function() {
  let page: RSSFeedReaderTemplatePage;

  beforeEach(() => {
    page = new RSSFeedReaderTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
