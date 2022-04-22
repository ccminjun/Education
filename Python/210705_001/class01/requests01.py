import requests
url = 'http://naver.co.kr'
movie = requests.get(url)
print(movie.text)