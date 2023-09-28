import { webTemplatePage } from './app.po';

describe('web App', function() {
  let page: webTemplatePage;

  beforeEach(() => {
    page = new webTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
