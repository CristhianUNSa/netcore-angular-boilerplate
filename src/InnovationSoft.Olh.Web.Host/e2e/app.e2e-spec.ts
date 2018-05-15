import { OlhTemplatePage } from './app.po';

describe('Olh App', function() {
  let page: OlhTemplatePage;

  beforeEach(() => {
    page = new OlhTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
