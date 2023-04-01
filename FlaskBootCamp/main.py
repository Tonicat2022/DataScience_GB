from flask import Flask


app = Flask(__name__)


@app.route('/')
def main():
    return "<h1>Hello World<h1><br><a href='/index'>go to second page</a>"

@app.route('/index')
def index():
    return "<h2>It is my first website<h2><br><a href='/'>Back to Homepage</a>"


if __name__ == '__main__':
    app.run()